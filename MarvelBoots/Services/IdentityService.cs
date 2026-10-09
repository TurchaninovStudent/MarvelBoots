using MarvelBoots.Models;
using MarvelBoots.Models.Enums;

namespace MarvelBoots.Services
{
    /// <summary>
    /// Сервис для идентификации пользователя
    /// </summary>
    public static class IdentityService
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public static User User { get; set; } = null;

        /// <summary>
        /// Авторизован
        /// </summary>
        public static bool IsAuthorized => User != null;

        /// <summary>
        /// Пользователь является ролью
        /// </summary>
        public static bool Is(Role role) => GetRole() == role;

        public static Role GetRole()
        {
            if (User == null)
            {
                return Role.Guest;
            }

            switch (User.UserRole.Name)
            {
                case "Менеджер":
                    return Role.Manager;

                case "Администратор":
                    return Role.Admin;

                default:
                    return Role.User;
            }
        }
    }
}
