using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data;

public class DbInitializer
{
    public static async Task Initialize(AnnouncementContext context, UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User
            {
                UserName = "dominik",
                Email = "dominik@test.com"
            };

            await userManager.CreateAsync(user, "Pa$$word1");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User
            {
                UserName = "admin",
                Email = "admin@test.com"
            };

            await userManager.CreateAsync(admin, "Pa$$word1");
            await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
        }

        if (context.Announcements.Any()) return;

        var announcements = new List<Announcement>
        {
            new Announcement
            {
                AnnouncementTitle = "Usługi stolarskie w okolicy",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 200,
                Location = "Rzeszów",
                Industry = "stolarstwo",
                PhoneNumber = "725725724",
                SkypeNumber = "lukas23",
                PhotoUrl = "/images/people/lukas.png",
                FirstName = "Łukasz",
                LastName = "Nowak",
                AnnouncementOwner = "dominik",
                OptionalEmail = "lukas23@mail.com"
            },
            new Announcement
            {
                AnnouncementTitle = "Usługi spawalnicze w okolicy",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 100,
                Location = "Kraków",
                Industry = "spawanie",
                PhoneNumber = "726062009",
                SkypeNumber = "adas99",
                PhotoUrl = "/images/people/lukas.png",
                FirstName = "Adam",
                LastName = "Kowalski",
                AnnouncementOwner = "dominik",
                OptionalEmail = "adas99@gmail.com"
            },
            new Announcement
            {
                AnnouncementTitle = "Usługi informatyczne w okolicy",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 100,
                Location = "Lublin",
                Industry = "informatyka",
                PhoneNumber = "345091123",
                SkypeNumber = "anna.k2",
                PhotoUrl = "/images/people/anna.png",
                FirstName = "Anna",
                LastName = "Nowaczkiewicz",
                AnnouncementOwner = "dominik",
                OptionalEmail = "ania66@wp.pl"
            },
            new Announcement
            {
                AnnouncementTitle = "Usługi budowlane",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 100,
                Location = "Warszawa",
                Industry = "budownictwo",
                PhoneNumber = "777341001",
                SkypeNumber = "tomek.n",
                PhotoUrl = "/images/people/anna.png",
                FirstName = "Tomek",
                LastName = "Nowak",
                AnnouncementOwner = "dominik",
                OptionalEmail = "thomasnnnn@onet.pl"
            },
            new Announcement
            {
                AnnouncementTitle = "Malowanie proszkowe",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 30,
                Location = "Gdańsk",
                Industry = "malowanie proszkowe",
                PhoneNumber = "656898100",
                SkypeNumber = "adas.w3",
                PhotoUrl = "/images/people/anna.png",
                FirstName = "Adam",
                LastName = "Wawrej",
                AnnouncementOwner = "dominik",
                OptionalEmail = "adas.w3333@wp.pl"
            },
            new Announcement
            {
                AnnouncementTitle = "Usługi ogrodnicze",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 75,
                Location = "Lubin",
                Industry = "ogrodnictwo",
                PhoneNumber = "656898100",
                SkypeNumber = "kamilo.w3",
                PhotoUrl = "/images/people/anna.png",
                FirstName = "Kamil",
                LastName = "Kowalski",
                AnnouncementOwner = "dominik",
                OptionalEmail = "kamilo.w3@gmail.com"
            },
            new Announcement
            {
                AnnouncementTitle = "Usługi stolarskie w okolicy",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 900,
                Location = "Jarosław",
                Industry = "stolarstwo",
                PhoneNumber = "725725724",
                SkypeNumber = "igor.nowak",
                PhotoUrl = "/images/people/anna.png",
                FirstName = "Igor",
                LastName = "Nowak",
                AnnouncementOwner = "dominik",
                OptionalEmail = "igor.nowak345@wp.pl"
            },
        };

        foreach (var announement in announcements)
        {
            context.Announcements.Add(announement);
        }

        context.SaveChanges();
    }
}