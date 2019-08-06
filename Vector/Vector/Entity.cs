
namespace VectorFramework
{
    public abstract class Entity : IDrawable, IMovable
    {
        private static int baseId = 0; 

        public int Id { get; private set; }
        public string Name { get; set; }
        public ColorEntity Color { get; set; }

        protected Entity()
        {
            Id = baseId++;
            Name = string.Empty;
            Color = ColorEntity.Black;
        }

        public abstract void Draw();
        public abstract void Move(Vector2 distance);
        public abstract void MoveTo(Vector2 newCenter);
    }
}
