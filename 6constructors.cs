class Fifa
{
    public string host;
    public DateTime year;
    public string winner;
    public string[] teams;

// default constructors
    public Fifa()
    {
        
    }

   // paramaterized constructor
    public Fifa(string h)
    {
        host=h;
    }
// multi parameterized constructor
     public Fifa(string h, DateTime years, string w, string[] tms)
    {
        host=h;
        year=years;
        winner=w;
        teams=tms;

    }
    //Garbage collections


}