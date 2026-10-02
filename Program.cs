Console.WriteLine("Hello, World!");

// snabb, fast 

List<Word> words = [
    /*("snabb", "fast"),
    ("snabb", "quick"),
    ("glad", "glad"),*/
    new Word ("swedish", "english", "snabb", "fast"),
    new Word ("swedish", "english", "glad", "happy")


];

foreach (var word in words)
{
    Console.WriteLine($"From: {word.FromLanguage} - {word.FromWord} => {word.ToLanguage} - {word.ToWord}");
}

var dict = (); // (key => value)

foreach  (var word in words)
{
    dict[word.FromWord] = word.ToWord;
    
}