using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    /*
     * Для всех приватных полей класса Walkman создайте и реализуйте соответствующие сеттеры и геттеры.
     * Для сеттера поля soundVolume необходимо:
     *      1) Устанавливать значение 0, если передано отрицательное значение.
     *      2) Устанавливать значение 100, если передано значение большее 100.
     * В сеттере поля currentSong необходимо устанавливать значение полю isOn - false, если текущее значение поля null или пустая строка.
     * Шаблон задачи изменять нельзя.
     */

    public class Walkman
    {
        private int soundVolume = 50;
        private string currentSong = "Oooo...you touch my tralala";
        public bool isOn = true;

        public static void Main(string[] args)
        {
            Walkman walkman = new Walkman();
            walkman.SetSoundVolume(120);
            walkman.SetCurrentSong("");
            Console.WriteLine("Громкость: " + walkman.GetSoundVolume());
            Console.WriteLine("Текущая песня: " + walkman.GetCurrentSong());
            Console.WriteLine("Walkman включен: " + walkman.isOn);
        }

        /* Добавьте свой код ниже */
        public Walkman()
        {
            soundVolume = 50; 
            currentSong = "";
            isOn = false;
        }

        public int GetSoundVolume()
        {
            return soundVolume;
        }

        public void SetSoundVolume(int volume)
        {
            if (volume < 0)
                soundVolume = 0;
            else if (volume > 100)
                soundVolume = 100;
            else
                soundVolume = volume;
        }

        public string GetCurrentSong()
        {
            return currentSong;
        }

        public void SetCurrentSong(string song)
        {
            currentSong = song;
            if (song == "" || song.Trim() == "")
            {
                isOn = false;
            }
            else
            {
                isOn = true; 
            }

        }
    }
}