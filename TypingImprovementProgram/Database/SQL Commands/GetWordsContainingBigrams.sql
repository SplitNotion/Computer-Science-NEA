SELECT Words.WordID, Words.Word FROM Words, WordBigrams, PossibleBigrams 
WHERE Words.WordID = WordBigrams.WordID AND 
WordBigrams.BigramID = PossibleBigrams.BigramID AND
PossibleBigrams.Bigram = 'pr';