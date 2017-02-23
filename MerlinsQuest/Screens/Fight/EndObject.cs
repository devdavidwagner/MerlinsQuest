using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MerlinsQuest.Screens.Fight
{
    class EndObject : GameScene
    {
        SpriteBatch spriteBatch;
        Texture2D endObject;

        EndObjectComponent objComp;


        public EndObjectComponent ObjComp
        {
            get
            {
                return objComp;
            }
            set
            {
                objComp = value;
            }

        }
        public EndObject(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            endObject = game.Content.Load<Texture2D>("Images2/door");


            objComp = new EndObjectComponent(game, spriteBatch,
                endObject);

            this.Components.Add(objComp);



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
