using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    /*Builder es un patrón de diseño creacional que nos permite construir objetos complejos 
     paso a paso. El patrón nos permite producir distintos tipos y representaciones de un objeto empleando el mismo código de construcción.*/

    public class UserAdmin {

        public string Permissions { get; set; }
        public string WelcomeMessage { get; set; }
    }
    public class UserOperation {
        public string Permissions { get; set; }
        public string WelcomeMessage { get; set; }
    }
    public interface IBuilder
    {
        
        void Reset();
        void SetPermissions();
        void Welcome(string name);
    }

    public class UserAdminBuilder : IBuilder
    {
        private UserAdmin _admin = new();
        public void Reset()
        {
            _admin = new();
        }

        public void SetPermissions()
        {
            _admin.Permissions = "Persmisos asignados al usuario Admin";
        }

        public void Welcome(string name)
        {
            _admin.WelcomeMessage = $"Hola, USUARIO ADMIN: {name}";
        }

        public UserAdmin Build() => this._admin;
    }

    public class UserOperationBuilder : IBuilder
    {
        private UserOperation _userOperation = new();

        public void Reset()
        {
            _userOperation = new();
        }

        public void SetPermissions()
        {
            _userOperation.Permissions = $"Persmisos asignados al usuario de Operación";
        }

        public void Welcome(string name)
        {
            _userOperation.WelcomeMessage = $"Hola, USUARIO DE OPERACIÓN: {name}";
        }

        public UserOperation Build() => this._userOperation;
    }
}
