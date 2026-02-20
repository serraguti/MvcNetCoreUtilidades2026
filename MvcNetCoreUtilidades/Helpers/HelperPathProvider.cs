namespace MvcNetCoreUtilidades.Helpers
{
    //Enumeracion con las carpetas que deseemos subir ficheros
    public enum Folders { Uploads, Images, Facturas, Temporal, Productos }
    public class HelperPathProvider
    {
        private IWebHostEnvironment hostEnvironment;

        public HelperPathProvider(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment; 
        }

        //TENDREMOS UN METODO QUE SE ENCARGAR DE RESOLVER LA RUTA 
        //COMO STRING CUANDO RECIBAMOS EL FICHERO Y LA CARPETA
        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";
            if (folder == Folders.Images)
            {
                carpeta = "images";
            }else if (folder == Folders.Uploads)
            {
                carpeta = "uploads";
            }else if (folder == Folders.Facturas)
            {
                carpeta = "facturas";
            }else if (folder == Folders.Temporal)
            {
                carpeta = "temp";
            }else if (folder == Folders.Productos)
            {
                carpeta = Path.Combine("images", "productos");
            }
            string rootPath = this.hostEnvironment.WebRootPath;
            string path = Path.Combine(rootPath, carpeta, fileName);
            return path;
        }
    }
}
