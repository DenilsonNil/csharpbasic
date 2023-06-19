namespace CSharpBasic
{
    public class FilesAndDirectories
    {
        //DirectoryInfo e FileInfo
        //File e Directory
        public void create()
        {
            FileInfo file1 = new FileInfo(@"C:\info\arq1.txt");
            file1.Create();

            File.Create(@"C:\info\arq1.txt");

            file1.CopyTo(@"C:\info\copia1.txt");

            File.Copy(@"C:\info\arq1.txt", @"C:\info\copia1.txt");

            file1.MoveTo(@"C:\info\destino\copia1.txt");

            File.Copy(@"C:\info\arq1.txt", @"C:\info\destino\copia1.txt");

            Console.WriteLine(file1.Name); // Retorna o nome do arquivo
            Console.WriteLine(file1.Extension); // Retorna a extensão do arquivo
            Console.WriteLine(file1.Exists); // Retorna um booleano indicando se o arquivo existe
            Console.WriteLine(file1.Directory); //Retorna o diretório atual onde o arquivo está
            Console.WriteLine(file1.FullName); // Retorna o caminho completo.

            DirectoryInfo dir1 = new DirectoryInfo(@"C:\info");
            dir1.Create();

            DirectoryInfo dir2 = new DirectoryInfo(@"C:\temp");
            dir2.Create();

            dir1.MoveTo(@"C:\temp");
            Directory.Move(@"C:\info", @"C:\temp");

            Directory.CreateDirectory(@"C:\temp\subdir");

            string[] arquivos = Directory.GetFiles(@"C:\temp");

            foreach (string arquivo in arquivos) { Console.WriteLine(arquivo); }

            string[] arquivosComecadosComC = Directory.GetFiles(@"C:\temp", "c*");

            FileInfo[] dir1files = dir1.GetFiles();

            DriveInfo driveInfo = new DriveInfo(@"C:");

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.IsReady);
            }

            string texto = File.ReadAllText(@"C:\curso\texto.text"); //Retorna uma string com o conteúdo do arquivo
            string[] strings = { "linha 1", "linha 2" };
            File.WriteAllLines(@"c:\file.txt", strings);
        }
    }
}
