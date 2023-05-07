using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    public class Usuario
    {
        #region Atributos

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreusuario;
        private string _contraseña;
        private string _mail;

        #endregion

        #region Propiedades

        public int Id 
        { 
            get { return this._id; } 
            set { this._id = value; }
        }

        public string Nombre 
        { 
            get { return this._nombre; } 
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string NombreUsuario
        {
            get { return this._nombreusuario; }
            set { this._nombreusuario = value; }
        }

        public string Contraseña
        {
            get { return this._contraseña; }
            set { this._contraseña = value; }
        }

        public string Mail 
        {
            get { return this._mail; }
            set { this._mail = value; }

        }

        #endregion

        #region Constructor

        public Usuario(int id, string nombre, string apellido, string nombreusuario, string contraseña, string mail)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreusuario = nombreusuario;
            _contraseña = contraseña;
            _mail = mail;
        }

        #endregion










    }
}
