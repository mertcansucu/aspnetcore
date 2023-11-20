using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{

    // course/index
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
        */
       // return "course/index";// geri dönüş

       var course = new Course(); //bunu yapma nedenim model altında oluşturduğum veritabanı bilgilerini çekip nesne olarak kullanmak

       course.Id = 1;
       course.Title = "Aspnet core kursu";

       return View(course);//dinamik olarak veriyi alıp tasarım ekranımda kullanmak için yaptım
    }
    
    // course/list

    /*
    public string List(){
        return "course/list";
    }

    */
    public IActionResult List(){
        return View();
        //return View("CourseList"); bunu mesela ben başka isimdeki yani :public IActionResult List() değilde başka bir view dödermek istersem böyle yaparım
    }
}