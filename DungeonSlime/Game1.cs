using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime;

public class Game1 : Core
{
    public Game1() : base("Dungeon Slime", 1280, 720, false) // (string title, int width, int height, bool fullScreen)
    {
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        Console.WriteLine("Game is initializing...");
        base.Initialize();
        // TODO: Add your initialization logic here
        Console.WriteLine("Initializing complete");
    }

    protected override void LoadContent()
    {
        Console.WriteLine("Loading content...");
        // TODO: use this.Content to load your game content here
        Console.WriteLine("Loading complete");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);

    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
