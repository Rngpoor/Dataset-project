// Reza Naghipoor 


string address1 = @"C:\orders.csv";
string address2 = @"C:\tehran.csv";

StreamReader Service = new StreamReader(address1);

StreamWriter Reader = new StreamWriter(address2);
string line;
while (!Service.EndOfStream)
{
    line = Service.ReadLine();
    if (line.Contains("تهران"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("اصفهان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("تبریز"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("مشهد"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("مازندران"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("اراک"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("شهرکرد"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("ایزد شهر"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("زابل"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("کرج"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("کرمان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("کیش"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("ارومیه"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("خرم اباد"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("یزد"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("اهواز"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("هرمزگان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("بیرجند"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("گیلان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("زنجان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("مازندران"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("سمنان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("سنندج"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("فارس"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("قزوین"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("قم"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("تهران"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("تهران"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("کرمانشاه"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("همدان"))
    {
        Reader.WriteLine(line);
    }
    if (line.Contains("یاسوج"))
    {
        Reader.WriteLine(line);
    }
 
}

Reader.Close();

Service.Close(); 

string Folder = @"D:\test";
if (!Directory.Exists(Folder))
{
    Directory.CreateDirectory(Folder);
}