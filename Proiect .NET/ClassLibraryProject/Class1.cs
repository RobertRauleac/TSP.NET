using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryProject
{
    public class Class1
    {
        private static string dataSource;


        public static void Insert(string name, double size, string path, string format, DateTime date) //se realizeaza inserarea unei poze/video in baza de date
        {
                using (Model1Container context = new Model1Container())
                {
                    Photo aux = new Photo()
                    {
                        name = name,
                        size = size,
                        path = path,
                        format = format,
                        date = DateTime.Now
                    };
                    context.Add(aux);
                    context.SaveChanges();
                }
        }

        public static void Delete(string par) //se realizeaza stergerea unei poze/video din baza de date
        {
            using (Model1Container context = new Model1Container())
            {
                Photo aux = new Photo { Name = par };
                context.Entry(aux).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public static void newCol(string par) //se realizeaza inserarea unei coloane noi in baza de date
        {
            //string connString = "data source=" + dataSource + ";initial catalog=Gallery; Trusted_Connection=True;";

            //string alterString = "alter table GallerySet add " + par + " varchar(20)";

           // using (SqlConnection cnn = new SqlConnection(connString))
            //{
                //try
                //{
                    //cnn.Open();
                    //using (SqlCommand cmd = new SqlCommand(alterString, cnn))
                    //{
                        //cmd.ExecuteNonQuery();

                    //}

                //}
                //catch (Exception ex)
                //{
                    //MessageBox.Show("ERROR New Column:" + ex.Message + "\nPlease try again!");
                //}
            //}
        }

        public static void deleteCol(string par) //se realizeaza stergerea unei coloane din baza de date
        {
            //string connString = "data source=" + dataSource + ";initial catalog=Gallery; Trusted_Connection=True;";

            
            //string alterString = "alter TABLE GallerySet drop column " + par;
            

            //using (SqlConnection cnn = new SqlConnection(connString))
            //{
                //try
                //{
                    //cnn.Open();
                    //using (SqlCommand cmd = new SqlCommand(alterString, cnn))
                    //{
                        //cmd.ExecuteNonQuery();

                    //}

                //}
                //catch (Exception ex)
                //{
                    //MessageBox.Show("ERROR Delete Column:" + ex.Message + "\nPlease try again!");
                //}
            //}
        }

        public static List<String> Info() //se realizeaza afisarea tuturor datelor din baza de date legate de o poza
        {
            using (Model1Container context = new Model1Container())
            {
                var photo = (from s in context.GallerySet select s).ToList();

                List<string> photos = new List<string>();

                foreach (var items in photo)
                {
                    photos.Add(items.Name);
                    photos.Add(items.Size);
                    photos.Add(items.Path);
                    photos.Add(items.Format);
                    photos.Add(Convert.ToString(items.Date));
                }
                return photos;

            }


        }

        public static void Update(string path, string column, string value) //se realizeaza updateul unei valori dintr-o coloana dorita din baza de date
        {
            /*using (Model1Container context = new Model1Container())
            {
                var result = context.Photo.SingleOrDefault(b => b.Path == path);
                if (result != null)
                {
                    result.Column = column;
                    result.Value = value;

                    context.AddOrUpdate(result);
                }

                context.SaveChanges();
            }*/
        }



    }
}


