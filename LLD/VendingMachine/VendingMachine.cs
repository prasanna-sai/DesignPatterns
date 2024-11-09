using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        private static VendingMachine _instance;
        public Inventory Inventory { get; private set; }
        private IState _idleState;
        private IState _readyState;
        private IState _dispenseState;
        private IState _returnChangeState;
        private IState _currentState;
        public Product SelectedProduct { get; private set; }
        public double TotalPayment { get; private set; }

        private VendingMachine()
        {
            Inventory = new Inventory();
            _idleState = new IdleState(this);
            _readyState = new ReadyState(this);
            _dispenseState = new DispenseState(this);
            _returnChangeState = new ReturnChangeState(this);
            _currentState = _idleState;
            SelectedProduct = null;
            TotalPayment = 0.0;
        }

        public static VendingMachine GetInstance()
        {
            if (_instance == null)
            {
                _instance = new VendingMachine();
            }
            return _instance;
        }

        public void SelectProduct(Product product)
        {
            _currentState.SelectProduct(product);
        }

        public void InsertCoin(Coin coin)
        {
            _currentState.InsertCoin(coin);
        }

        public void InsertNote(Note note)
        {
            _currentState.InsertNote(note);
        }

        public void DispenseProduct()
        {
            _currentState.DispenseProduct();
        }

        public void ReturnChange()
        {
            _currentState.ReturnChange();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public IState GetIdleState() => _idleState;
        public IState GetReadyState() => _readyState;
        public IState GetDispenseState() => _dispenseState;
        public IState GetReturnChangeState() => _returnChangeState;

        public void SetSelectedProduct(Product product)
        {
            SelectedProduct = product;
        }

        public void ResetSelectedProduct()
        {
            SelectedProduct = null;
        }

        public void AddCoin(Coin coin)
        {
            TotalPayment += coin.GetValue();
        }

        public void AddNote(Note note)
        {
            TotalPayment += note.GetValue();
        }

        public void ResetPayment()
        {
            TotalPayment = 0.0;
        }
    }
}
