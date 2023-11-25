namespace basics.Models
{
    public class Repository{
        //burayı oluşturmamın nedeni oluşturduğum veritabındaki verileri istedğim yerden istediğim veriyi çağırabilmek
        private static readonly List<Course> _courses=new();
        //private static readonly bir tane okunabilen üye

        static Repository(){
            _courses = new List<Course>(){
                new Course() {
                    Id = 1, 
                    Title = "aspnet kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "a1.jpg",
                    Tags = new string[] {"aspnet", "web geliştirme"},
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 2, 
                    Title = "php kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "a1.jpg",
                    Tags = new string[] {"php", "web geliştirme"},
                    isActive = false,
                    isHome = true
                },
                new Course() {
                    Id = 3,
                    Title = "django kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "a1.jpg",
                    isActive = true,
                    isHome = false
                 },
                new Course() {
                    Id = 4, 
                    Title = "javascript kursu", 
                    Description = "Güzel bir kurs", 
                    Image = "a1.jpg",
                    isActive = true,
                    isHome = true
                }
                
            };
        }

        public static List<Course> Courses{
            //private üyen,n public halini oluştur
            get{
                return _courses;
            }
        }

        //detay sayfaları için
        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}