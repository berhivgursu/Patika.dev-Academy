using System;
using System.Collections.Generic;
using System.Linq;

public class PhoneBook
{
    private List<Contact> contacts;

    public PhoneBook()
    {
        contacts = new List<Contact>
        {
            new Contact("Ali", "Yılmaz", "05551112233"),
            new Contact("Ayşe", "Kara", "05332224455"),
            new Contact("Mehmet", "Demir", "05443335566"),
            new Contact("Elif", "Çelik", "05056667788"),
            new Contact("Ahmet", "Şahin", "05227778899")
        };
    }

    public void AddContact()
    {
        Console.Write("İsim: ");
        string firstName = Console.ReadLine();
        Console.Write("Soyisim: ");
        string lastName = Console.ReadLine();
        Console.Write("Telefon Numarası: ");
        string phoneNumber = Console.ReadLine();

        contacts.Add(new Contact(firstName, lastName, phoneNumber));
        Console.WriteLine("Kişi başarıyla eklendi!");
    }

    public void DeleteContact()
    {
        Console.Write("Silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        string input = Console.ReadLine();
        Contact contact = contacts.FirstOrDefault(c =>
            c.FirstName.Equals(input, StringComparison.OrdinalIgnoreCase) ||
            c.LastName.Equals(input, StringComparison.OrdinalIgnoreCase));

        if (contact == null)
        {
            Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı.");
            Console.WriteLine("1- Silmeyi sonlandır | 2- Yeniden dene");
            string choice = Console.ReadLine();
            if (choice == "2")
                DeleteContact();
        }
        else
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} rehberden silinecek. Onaylıyor musunuz? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "y")
            {
                contacts.Remove(contact);
                Console.WriteLine("Kişi başarıyla silindi.");
            }
        }
    }

    public void UpdateContact()
    {
        Console.Write("Güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
        string input = Console.ReadLine();
        Contact contact = contacts.FirstOrDefault(c =>
            c.FirstName.Equals(input, StringComparison.OrdinalIgnoreCase) ||
            c.LastName.Equals(input, StringComparison.OrdinalIgnoreCase));

        if (contact == null)
        {
            Console.WriteLine("Kişi bulunamadı. 1- Vazgeç | 2- Tekrar dene");
            string choice = Console.ReadLine();
            if (choice == "2")
                UpdateContact();
        }
        else
        {
            Console.Write("Yeni telefon numarasını giriniz: ");
            string newNumber = Console.ReadLine();
            contact.PhoneNumber = newNumber;
            Console.WriteLine("Numara güncellendi.");
        }
    }

    public void ListContacts()
    {
        Console.WriteLine("Sıralama türünü seçiniz: (1) A-Z  (2) Z-A");
        string choice = Console.ReadLine();
        IEnumerable<Contact> sortedList = contacts;

        if (choice == "1")
            sortedList = contacts.OrderBy(c => c.FirstName);
        else if (choice == "2")
            sortedList = contacts.OrderByDescending(c => c.FirstName);

        Console.WriteLine("\nTelefon Rehberi");
        Console.WriteLine("************************************");
        foreach (var c in sortedList)
            Console.WriteLine($"İsim: {c.FirstName} Soyisim: {c.LastName} Telefon: {c.PhoneNumber}");
    }

    public void SearchContact()
    {
        Console.WriteLine("Arama tipi: (1) İsim/Soyisim  (2) Telefon");
        string choice = Console.ReadLine();
        List<Contact> results = new List<Contact>();

        if (choice == "1")
        {
            Console.Write("Aramak istediğiniz isim ya da soyisim: ");
            string keyword = Console.ReadLine();
            results = contacts.Where(c =>
                c.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        else if (choice == "2")
        {
            Console.Write("Aramak istediğiniz telefon numarası: ");
            string number = Console.ReadLine();
            results = contacts.Where(c => c.PhoneNumber.Contains(number)).ToList();
        }

        Console.WriteLine("\nArama Sonuçlarınız");
        Console.WriteLine("************************************");
        foreach (var c in results)
            Console.WriteLine($"İsim: {c.FirstName} Soyisim: {c.LastName} Telefon: {c.PhoneNumber}");

        if (results.Count == 0)
            Console.WriteLine("Eşleşen kişi bulunamadı.");
    }
}
