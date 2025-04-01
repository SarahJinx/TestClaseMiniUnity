namespace MiniUnity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creacion de nuestros gameObjects (RightClick -> Create Empty)
            GameObject go1 = new GameObject();
            GameObject go2 = new GameObject();

            // Creación y asignación de nuevos componentes
            SpriteRenderer spriteRenderer1 = new SpriteRenderer();   
            spriteRenderer1.color = ConsoleColor.Cyan;
            spriteRenderer1.sprite = '1';
            SpriteRenderer spriteRenderer2 = new SpriteRenderer();   
            spriteRenderer1.color = ConsoleColor.Magenta;
            spriteRenderer1.sprite = '2';
            // (RightClick -> Add Component -> SpriteRenderer)
            go1.AddComponent(spriteRenderer1);
            go2.AddComponent(spriteRenderer2);

            List<GameObject> gameObjects = new List<GameObject>();

            foreach (GameObject go in gameObjects)
            {
                go.Start();
            }
        }
    }
}
