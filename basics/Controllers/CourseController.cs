using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{

    // course/index bunu artık kullanmıyıcam çünkü her sayfanın detay sayfası var
    /*
         public IActionResult Index(){//public string Index() sadece string dödermek istersem böyle
        /*
        // dotnet watch run ile homecontroler içindeki sayfaya gitti ben sonrasında:
        http://localhost:5250/course/index ekleyince o sayfa açıldı ve course/index bu çıktıyı aldım

        http://localhost:5250/course/ böylede yapsam yine index kısmına gider çünkü otomatik dolduruyor ben default fonk. da belirttim:
        yeri program.cs de
        app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run(); kısmı.
        
       // return "course/index";// geri dönüş

       var course = new Course(); //bunu yapma nedenim model altında oluşturduğum veritabanı bilgilerini çekip nesne olarak kullanmak

       course.Id = 1;
       course.Title = "Aspnet core kursu";
       course.Description = "Güzel bir kurs";
       course.Image = "4.jpg";

       return View(course);//dinamik olarak veriyi alıp tasarım ekranımda kullanmak için yaptım
    }
    */
   
    
    // course/list

    /*
    public string List(){
        return "course/list";
    }

    */

    public IActionResult Details(int? id){
       /*sayfalara özel detay sayfası olduğu için repositoryden aldığı id ye göre tıkladığım kardtın bilgisini gösterecek
       var course = new Course(); 

       course.Id = 1;
       course.Title = "Aspnet core kursu";
       course.Description = "Güzel bir kurs";
       course.Image = "1.jpg";
       */
       
       if (id == null)
       {
        return Redirect("/course/list");//eğer id boşsa hangi sayfaya gideceğini söyledim
        // return RedirectToAction("List","Course");diğer kullanımı
       }
       
       var course = Repository.GetById(id);

       return View(course);
    }
    public IActionResult List(){
        /* bu listeye artık burda ihtiyacım yok Repository içinden çekicem
        var kurslar = new List<Course>(){//böyle yapmamın nedeni üste sadece bir veri göndermek için vardı artık birden fazla veriyi göstermek için yaptım
            new Course() {Id = 1, Title = "aspnet kursu", Description = "Güzel bir kurs", Image = "1.jpg"},
            new Course() {Id = 2, Title = "php kursu", Description = "Güzel bir kurs", Image = "2.jpg"},
            new Course() {Id = 4, Title = "javascript kursu", Description = "Güzel bir kurs", Image = "3.jpg"},
            new Course() {Id = 3, Title = "django kursu", Description = "Güzel bir kurs", Image = "4.jpg"}

            return View("CourseList", kurslar);
        };
        */
        return View("CourseList", Repository.Courses);
        //return View("CourseList"); bunu mesela ben başka isimdeki yani :public IActionResult List() değilde başka bir view dödermek istersem böyle yaparım
    }
}