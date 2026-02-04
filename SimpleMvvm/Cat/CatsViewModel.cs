using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using CommunityToolkit.Mvvm.Input;

using SimpleMvvm.Repository;

namespace SimpleMvvm.Cat
{
    public class CatsViewModel : INotifyPropertyChanged
    {
        private CatModel[] _cats;
        private string _catName;
        private CatColor _catCatColor;
        private DateTime _catBirthDate;
        private int _index;

        public string CatName
        {
            get => this._catName;
            set => this.SetField(ref this._catName, value);
        }

        public CatColor CatColor
        {
            get => this._catCatColor;
            set => this.SetField(ref this._catCatColor, value);
        }

        public DateTime CatBirthDate
        {
            get => this._catBirthDate;
            set => this.SetField(ref this._catBirthDate, value);
        }

        public ICommand Previous { get; private set; }

        public ICommand Next { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CatsViewModel()
        {
            this._cats = new CatRepository().GetAllCats();

            this.CatName = this._cats[this._index].Name;
            this.CatColor = this._cats[this._index].Color;
            this.CatBirthDate = this._cats[this._index].BirthDate;

            this.Previous = new RelayCommand(() =>
                {
                    this._index = CustomMath.Mod(this._index - 1, this._cats.Length);
                    this.CatName = this._cats[this._index].Name;
                    this.CatColor = this._cats[this._index].Color;
                    this.CatBirthDate = this._cats[this._index].BirthDate;
                });

            this.Next = new RelayCommand(() =>
                {
                    this._index = (this._index + 1) % this._cats.Length;
                    this.CatName = this._cats[this._index].Name;
                    this.CatColor = this._cats[this._index].Color;
                    this.CatBirthDate = this._cats[this._index].BirthDate;
                });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}