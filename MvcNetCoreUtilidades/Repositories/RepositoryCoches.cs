using MvcNetCoreUtilidades.Models;

namespace MvcNetCoreUtilidades.Repositories
{
    public class RepositoryCoches
    {
        private List<Coche> Cars;

        public RepositoryCoches()
        {
            this.Cars = new List<Coche>
            {

              new Coche { IdCoche = 1, Marca = "Pontiac"

             , Modelo = "Firebird", Imagen = "https://imagenes.topgear.es/files/image_1920_1080/uploads/imagenes/2023/06/26/68ca8307d8bc8.jpeg"},

              new Coche { IdCoche = 2, Marca = "Volkswagen"

             , Modelo = "Escarabajo", Imagen = "https://www.qonecta.com/documents/80345/95274/herbie-el-volkswagen-beetle-mas.jpg"},

              new Coche { IdCoche = 3, Marca = "Ferrari"

             , Modelo = "Testarrosa", Imagen = "https://www.lavanguardia.com/files/article_main_microformat/uploads/2017/01/03/5f15f8b7c1229.png"},

              new Coche { IdCoche = 4, Marca = "Ford"

             , Modelo = "Mustang GT", Imagen = "https://d1gl66oyi6i593.cloudfront.net/wp-content/uploads/2015/03/prueba-ford-mustang-gt-20151.jpg"},
                      new Coche
        {
            IdCoche = 5,
            Marca = "DMG"            ,
            Modelo = "Deloread",
            Imagen = "https://i.blogs.es/135a00/delorean-dmc12/450_1000.jpg"
        }


             };
        }

        public List<Coche> GetCoches()
        {
            return this.Cars;
        }

        public Coche FindCoche(int idCoche)
        {
            return this.Cars.Find(z => z.IdCoche == idCoche);
        }
    }
}
