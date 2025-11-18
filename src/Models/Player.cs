using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PlayerModel
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass { get; set; }
        private int _hitPoints { get; set; }
        private int _experiencePoint { get; set; }
        public int _level { get; set; }
        public int _gold { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value; OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoint
        {
            get { return _experiencePoint; }
            set
            {
                _experiencePoint = value;
                OnPropertyChanged("ExperiencePoint");
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
