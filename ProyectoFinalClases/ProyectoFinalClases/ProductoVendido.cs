using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    public class ProductoVendido
    {
        #region Atributos

        private int _id;
        private int _idproducto;
        private double _stock;
        private int _idventa;

        #endregion


        #region Propiedades

        public int Id { get { return this._id; } set { this._id = value; } }

        public int IdProducto { get { return this._idproducto; } set { this._idproducto = value; } }

        public double Stock { get { return this._stock;} set { this._stock = value; } }  

        public int IdVenta { get { return this._idventa; } set{ this._idventa = value; } }

        #endregion

        #region Constructor

        public ProductoVendido(int id, int idproducto, double stock, int idventa)
        {
            _id = id;
            _idproducto = idproducto;
            _stock = stock;
            _idventa = idventa;
        }

        #endregion







    }
}
