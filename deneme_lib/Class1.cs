namespace deneme_lib
{
    public class Class1
    {
        public int sonuc1,sonuc2;
        public int Toplama(int x, int y)
        {
            sonuc1 = x + y;
            return sonuc1;
        }
        public int cikarma(int z,int w)
        {
            sonuc2 = z - w;
            return sonuc2;
        }
        public string adi { get; set; }
        public string email_ { get; set; }
    }
}
