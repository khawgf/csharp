using BusinessLayer;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHACHSAN
{
   public class myFunctions
    {
        public static string _macty;
        public static string _madvi;
        public static string _srv;
        public static string _us;
        public static string _pw;
        public static string _db;

        static SqlConnection con = new SqlConnection();
        public static void taoketnoi()
        {

            con.ConnectionString = "Data Source = .;Initial Catalog = QLKS; User ID=sa; Password=123;";
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void dongketnoi()
        {
            con.Close();
        }
        public static DataTable laydulieu(string qr)
        {
            taoketnoi();
            DataTable datatbl = new DataTable();
            SqlDataAdapter dap =    new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand(qr,con);
            dap.Fill(datatbl);
            dongketnoi();
            return datatbl;
        }
        public static void ThucHienLenh(string qr)
        {
            taoketnoi();

            try
            {
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý các trường hợp ngoại lệ nếu cần
                Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
            finally
            {
                dongketnoi();
            }
        }


        public static void XuatDuLieuRaExcel(string query, string tenTepExcel, string tieude)
        {
            taoketnoi();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Users");

                SqlDataAdapter dap = new SqlDataAdapter();
                dap.SelectCommand = new SqlCommand(query, con);

                DataTable datatbl = new DataTable();
                dap.Fill(datatbl);

                if (datatbl != null && datatbl.Rows.Count > 0)
                {
                    // Điền tiêu đề "THÔNG TIN BẢNG ĐẶT PHÒNG" vào ô A1
                    worksheet.Cells["A1"].Value = tieude;
                    // Định dạng tiêu đề
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.Font.Size = 24;

                    // Điền tiêu đề cột tương ứng
                    for (int col = 1; col <= datatbl.Columns.Count; col++)
                    {
                        worksheet.Cells[2, col].Value = datatbl.Columns[col - 1].ColumnName;
                        worksheet.Cells[2, col].Style.Font.Bold = true; // In đậm tiêu đề cột
                    }

                    // Điền dữ liệu từ DataTable vào tệp Excel
                    for (int row = 3; row <= datatbl.Rows.Count + 2; row++)
                    {
                        for (int col = 1; col <= datatbl.Columns.Count; col++)
                        {
                            worksheet.Cells[row, col].Value = datatbl.Rows[row - 3][col - 1];
                        }
                    }

                    // Lưu tệp Excel vào ổ đĩa với tên được chỉ định
                    using (var stream = new FileStream(tenTepExcel, FileMode.Create))
                    {
                        package.SaveAs(stream);
                    }
                }

                dongketnoi();
            }
        }



        public static DateTime GetFirstDayInMont(int year, int month)
        {
            return new DateTime(year, month,1);
        }



    }
}
