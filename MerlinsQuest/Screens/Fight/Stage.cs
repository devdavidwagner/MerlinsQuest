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
    class Stage : GameScene
    {
        SpriteBatch spriteBatch;
        Texture2D platform;

        StageComponent stageComp;


        public StageComponent StageComp
        {
            get
            {
                return stageComp;
            }
            set
            {
                stageComp = value;
            }

        }
        public Stage(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            platform = game.Content.Load<Texture2D>("Images2/stage");


            stageComp = new StageComponent(game, spriteBatch,
                platform);

            this.Components.Add(stageComp);



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
