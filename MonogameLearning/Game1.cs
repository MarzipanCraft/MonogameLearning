using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Learning
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        InputHelper inputHelper;

        public Game1()
        { graphics = new GraphicsDeviceManager(this); Content.RootDirectory = "Content"; }

        protected override void Initialize() { base.Initialize(); }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            inputHelper = new InputHelper();
        }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime)
        {
            inputHelper.Update();

            if (inputHelper.IsNewKeyPress(Keys.Escape)) { Exit(); }

            //check keyboard for press, hold, release
            if (inputHelper.IsNewKeyPress(Keys.Space))
            { System.Diagnostics.Debug.WriteLine("Spacebar pressed."); }

            if (inputHelper.IsKeyDown(Keys.Space))
            { System.Diagnostics.Debug.WriteLine("Spacebar held down."); }

            if (inputHelper.IsNewKeyRelease(Keys.Space))
            { System.Diagnostics.Debug.WriteLine("Spacebar released."); }

            //check mouse for press, hold, release
            if (inputHelper.IsNewMouseButtonPress(MouseButtons.LeftButton))
            { System.Diagnostics.Debug.WriteLine("Left Mouse Button pressed."); }

            if (inputHelper.IsMouseButtonDown(MouseButtons.LeftButton))
            { System.Diagnostics.Debug.WriteLine("Left Mouse Button held down."); }

            if (inputHelper.IsNewMouseButtonRelease(MouseButtons.LeftButton))
            { System.Diagnostics.Debug.WriteLine("Left Mouse Button released."); }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}
