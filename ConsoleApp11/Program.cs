using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DNSStore.Classes;
using DNSStore.Interfaces;
using DNSStore.Events;

namespace DNSStore
{
    // Программа
    class Program
    {
        static void Main(string[] args)
        {
            // Создание магазина техники
            DNSStore.Classes.DNSStore store = new DNSStore.Classes.DNSStore();

            // Добавление товаров в магазин техники
            store.AddProduct(new Product() { Name = "Яндекс станция", Price = 7349 });
            store.AddProduct(new Product() { Name = "Гарнитура Razor", Price = 10000 });
            store.AddProduct(new Product() { Name = "Мышка Logitech", Price = 5000 });
            store.AddProduct(new Product() { Name = "Клавиатура Razer", Price = 7000 });

            // Создание пользователя
            User user = new User("Дмитрий", "dmitry@example.com");

            // Подписка на событие
            store.OrderPlaced += Store_OrderPlaced;

            // Дмитрий открывает онлайн сайт днс
        Console.WriteLine("Дмитрий открывает онлайн сайт DNS");

            // Дмитрий листает интернет-магазин для выбора подарка на день рождения
            Console.WriteLine("Дмитрий листает интернет-магазин для выбора подарка на день рождения");

            // Дмитрия привлекает новая яндекс станция по выгодной цене
            Console.WriteLine("Дмитрия привлекает новая Яндекс станция по выгодной цене");

            // Дмитрий отправляет ее в корзину
            user.AddToCart(store.GetProducts()[0]);

            // Дмитрий видит акцию "2+1"
            Console.WriteLine("Дмитрий видит акцию \"2+1\"");

            // Дмитрий решает обновить свою гарнитуру
            Console.WriteLine("Дмитрий решает обновить свою гарнитуру");

            // Дмитрий видит желанную гарнитуру Razor
            Console.WriteLine("Дмитрий видит желанную гарнитуру Razor");

            // Дмитрий отправляет ее в корзину
            user.AddToCart(store.GetProducts()[1]);

            // Дмитрий заходит в корзину и выбирает метод оплаты банковской карты
            Console.WriteLine("Дмитрий заходит в корзину и выбирает метод оплаты банковской карты");

            // Создание сервиса доставки
            IDeliveryService deliveryService = new RussianPostDeliveryService();

            // Размещение заказа
            user.PlaceOrder(store, deliveryService, "улица Ленина, дом 12, квартира 15");

            // Получение информации о складе
            store.GetWarehouseInfo();
        }

        private static void Store_OrderPlaced(object sender, OrderEventArgs e)
        {
            // Вывод информации о заказе
            Console.WriteLine("Заказ размещен.");
            Console.WriteLine($"Покупатель: Дмитрий");
            Console.WriteLine($"Товары в заказе:");
            foreach (IProduct product in e.Order.Products)
            {
                Console.WriteLine($"\t{product.Name}");
            }
            Console.WriteLine($"Общая стоимость: {e.Order.TotalPrice}");
            Console.WriteLine($"Адрес доставки: {e.Order.DeliveryAddress}");

            // Доставка заказа
            e.Order.DeliveryService.DeliverOrder(e.Order);
        }
    }
}