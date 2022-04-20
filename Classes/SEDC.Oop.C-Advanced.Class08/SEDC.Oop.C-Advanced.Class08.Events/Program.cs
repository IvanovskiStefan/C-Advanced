

using SEDC.Oop.C_Advanced.Class08.Events.Entites;

Market tineks = new Market()
{
    Name = "Tineks",
    CurrentProductType= ProductType.Food

};

Market reptil = new Market()
{
    Name = "Reptil",
    CurrentProductType = ProductType.Cosmetics

};

Market neptun = new Market()
{
    Name = "Neptun",
    CurrentProductType = ProductType.Electronics

};


User stefan = new User("stefan", "Ivanovski", 33, "ivanovski@ivanovski.com");
User aneta = new User("aneta", "stankovska", 23, "stankovska@stankovska.com");
User aleksandar = new User("aleksandar", "zivkovic", 35, "zivkovic@zivkovic.com");
User ivan = new User("ivan", "dzikovski", 31, "ivan@ivan.com");

tineks.SubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
tineks.Send();
reptil.SubscribeToPromotion(stefan.ReadPromotion,stefan.Email);
reptil.Send();
neptun.SubscribeToPromotion(aneta.ReadPromotion,aneta.Email);
neptun.Send();








