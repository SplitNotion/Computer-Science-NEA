//private void ShowTestLines(string title)
//{
//    var lines = Characters
//        .GroupBy(c => c.Line)
//        .OrderBy(g => g.Key)
//        .Select(g => $"Line {g.Key}: {new string(g.Select(c => c.Character == ' ' ? '·' : c.Character).ToArray())}");

//    MessageBox.Show(
//        title + "\n\n" + string.Join("\n", lines),
//        "Test Generation Debug"
//    );
//}



//ShowTestLines("BEFORE WORD MOVEMENT");