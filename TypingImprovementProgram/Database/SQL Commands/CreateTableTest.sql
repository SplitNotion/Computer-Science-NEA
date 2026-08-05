                        IF NOT EXISTS (
                            SELECT *
                            FROM INFORMATION_SCHEMA.TABLES
                            WHERE TABLE_NAME = 'PossibleBigrams'
                        )
                        BEGIN
                            CREATE TABLE PossibleBigrams
                            (
                                BigramID INT PRIMARY KEY IDENTITY(1,1),
                                Bigram CHAR(2) NOT NULL
                            );
                        END;