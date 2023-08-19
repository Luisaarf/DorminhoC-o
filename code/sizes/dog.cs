namespace DorminhoCão.code.sizes
{
    public abstract class dog
    {
        private char gender;
        private int weight;
        private int age;
        private string? birth;
        private bool especial;
        private string? limitation;


        public char getGender(){
            return gender;
        }

        public int getWeight(){
            return weight;
        }

        public int getAge(){
            return age;
        }

        public string? getBirth(){
            return birth;
        }

        public bool getEspecial(){
            return especial;
        }

        public string? getLimitation(){
            return limitation;
        }

        public abstract string addToGroup();
    }
}