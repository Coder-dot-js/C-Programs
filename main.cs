using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

void Tick()
{
    // Game Tick
}

void CheckKeysPressed()
{
    // Check Keys Code
}

void Draw()
{
    // Draw Code
}

void Update()
{
    CheckKeysPressed();

    Tick();

    Draw();

    // Main Loop Code
}

// Main game loop
while (!Raylib.WindowShouldClose())
{
    Update();
}

Raylib.CloseWindow();
