START:
Console.WriteLine("Yasinizi qeyd ediniz: ");
int userAge = Convert.ToInt32(Console.ReadLine());
if(userAge > 18)
{
    Console.WriteLine("Imtahan kecid balinizi qeyd ediniz: ");
    int userAvgPoint = Convert.ToInt32(Console.ReadLine());
    if (userAvgPoint > 50)
    {
        Console.WriteLine("Sizin kursumuza qeydiyyatiniz muveffeqiyyetle qeyde alinmisdir . Tesekkurler :)");
    }
    else
    {
        Console.WriteLine("Sizin Baliniz Kursa qeydiyyat ucun yeterli deyildir . ");
    }
}
else
{
    Console.WriteLine("Sizin yasiniz kursa qeydiyyat ucun yeterli deyil . ");
}
goto START;

