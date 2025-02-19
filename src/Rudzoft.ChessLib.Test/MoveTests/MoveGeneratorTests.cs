/*
ChessLib, a chess data structure library

MIT License

Copyright (c) 2017-2022 Rudy Alex Kohn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using Rudzoft.ChessLib.Enums;
using Rudzoft.ChessLib.Factories;
using Rudzoft.ChessLib.Fen;
using Rudzoft.ChessLib.MoveGeneration;
using Rudzoft.ChessLib.Types;

namespace Rudzoft.ChessLib.Test.MoveTests;

public sealed class MoveGeneratorTests
{
    [Fact]
    public void InCheckMoveGeneration()
    {
        const string fen = "rnbqkbnr/1ppQpppp/p2p4/8/8/2P5/PP1PPPPP/RNB1KBNR b KQkq - 1 6";
        const int expectedMoves = 4;

        var g = GameFactory.Create(fen);

        // make sure black is in check
        Assert.True(g.Pos.InCheck);

        // generate moves for black
        var mg = g.Pos.GenerateMoves();
        var actualMoves = mg.Length;

        Assert.Equal(expectedMoves, actualMoves);
    }
    [Fact]
    public void InCheckMoveGeneration2()
    {
        const string fen = "2b1kb1r/4n1p1/1pPp3p/5p2/1P6/4q3/P2NKP2/1n3B1R w k - 0 47";
        const int expectedMoves = 3;

        var g = GameFactory.Create(fen);

        // make sure black is in check
        Assert.True(g.Pos.InCheck);

        // generate moves for black
        var mg = g.Pos.GenerateMoves();
        var actualMoves = mg.Length;

        Assert.Equal(expectedMoves, actualMoves);
    }
}