using Lab_05.BUS;
using Lab_05.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private string avatarFileName;

        public string ImageName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvsv);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setGridViewStyle(DataGridView dgvsv)
        {
            dgvsv.BorderStyle = BorderStyle.None;
            dgvsv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvsv.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgvsv.BackgroundColor = Color.White;
            dgvsv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindGrid(List<Student> listStudents)
        {
            dgvsv.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dgvsv.Rows.Add();
                dgvsv.Rows[index].Cells[0].Value = item.StudentID;
                dgvsv.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvsv.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                dgvsv.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvsv.Rows[index].Cells[4].Value = item.Major.Name + "";
                ShowAvatar(item.Avatar);
            }
        }

        private void ShowAvatar(string avatar)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picturesv.Image = null;
            }
            else
            {
                string parentDirectory =
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                picturesv.Image = Image.FromFile(imagePath);
                picturesv.Refresh();
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cbbkhoa.DataSource = listFacultys;
            this.cbbkhoa.DisplayMember = "FacultyName";
            this.cbbkhoa.ValueMember = "FacultyID";
        }

        private void chkchuyennganh_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkchuyennganh.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }

        private void bttthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng SinhVien từ dữ liệu người dùng nhập
                Student student = new Student()
                {
                    StudentID = txtmssv.Text,
                    FullName = txthoten.Text,
                    FacultyID = (int)cbbkhoa.SelectedValue,
                    AverageScore = GetAverageScore(txtdtb.Text),
                    Avatar = picturesv.Image != null ? Path.GetFileName(picturesv.ImageLocation) : null
                };

                // Gọi phương thức InsertUpdate để thêm hoặc cập nhật sinh viên
                studentService.InsertUpdate(student);

                // Thông báo thành công
                MessageBox.Show("Lưu thành công!");

                // Làm mới danh sách sinh viên sau khi thêm mới
                RefreshStudentList();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private double GetAverageScore(string input)
        {
            double averageScore;

            // Kiểm tra giá trị nhập vào và gán giá trị mặc định nếu không hợp lệ
            if (!double.TryParse(input, out averageScore))
            {
                averageScore = 0.0; // Giá trị mặc định mà bạn muốn
            }

            return averageScore;
        }
        private void RefreshStudentList()
        {
            try
            {
                // Lấy danh sách sinh viên từ database
                var listStudents = studentService.GetAll();

                // Gọi hàm BindGrid để cập nhật DataGridView
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải danh sách sinh viên: {ex.Message}");
            }
        }

        private void bttxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy MSSV của sinh viên cần xóa từ TextBox
                string mssv = txtmssv.Text;

                // Gọi hàm Delete để xóa sinh viên
                studentService.Delete(mssv);

                // Thông báo thành công
                MessageBox.Show("Xóa thành công!");

                // Cập nhật lại danh sách sinh viên trên DataGridView
                RefreshStudentList();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgvsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvsv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtmssv.Text = dgvsv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txthoten.Text = dgvsv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbbkhoa.Text = dgvsv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtdtb.Text = dgvsv.Rows[e.RowIndex].Cells[3].Value.ToString();

                }

            }
        }

        private void bttaddpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.jfif";
            openFileDialog.Title = "Chọn một ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy phần mở rộng file (vd: .jpg, .png)
                string fileExtension = Path.GetExtension(openFileDialog.FileName);

                // Lấy mã sinh viên từ TextBox
                string studentID = txtmssv.Text;

                // Đặt tên file theo định dạng {studentID}.{fileExtension}
                string fileName = $"{studentID}{fileExtension}";

                // Đường dẫn tới thư mục Images
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagesFolderPath = Path.Combine(parentDirectory, "Images");
                string imagePath = Path.Combine(imagesFolderPath, fileName);

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }

                // Sao chép ảnh vào thư mục với tên mới
                File.Copy(openFileDialog.FileName, imagePath, true);

                // Hiển thị ảnh trong PictureBox
                picturesv.Image = System.Drawing.Image.FromFile(imagePath);

                // Cập nhật tên file vào cơ sở dữ liệu
                SaveAvatarToDatabase(studentID, fileName);
            }
        }

        private void SaveAvatarToDatabase(string studentID, string fileName)
        {
            // Code sử dụng Entity Framework để cập nhật thông tin vào database
            using (var db = new ModelStudentDB())
            {
                var student = db.Students.Find(studentID);
                if (student != null)
                {
                    student.Avatar = avatarFileName;  // Cập nhật tên file avatar
                    db.SaveChanges();  // Lưu thay đổi vào CSDL
                }
            }
        }
    }
}
