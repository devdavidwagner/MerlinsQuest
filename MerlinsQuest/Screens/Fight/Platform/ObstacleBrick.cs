using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest.Screens.Fight.Platform
{
    class ObstacleBrick : GameScene
    {
        SpriteBatch spriteBatch;
        Texture2D obstacle;
        Vector2 position;
        

        ObstacleComponent obstComp;


        public ObstacleComponent ObstComp
        {
            get
            {
                return obstComp;
            }
            set
            {
                obstComp = value;
            }

        }
        public ObstacleBrick(Game game,
            SpriteBatch spriteBatch,
            Texture2D obstacle)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.obstacle = obstacle;
            this.position = position;

            obstComp = new ObstacleComponent(game, spriteBatch,
                obstacle);

            this.Components.Add(obstComp);



        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
