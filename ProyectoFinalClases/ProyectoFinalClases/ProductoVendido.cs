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

        public int Id { get { return _id; } set { _id = value; } }

        public int IdProducto { get { return _idproducto; } set { _idproducto = value; } }

        public double Stock { get { return _stock;} set { _stock = value; } }  

        public int IdVenta { get { return _idventa; } set{ _idventa = value; } }

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
