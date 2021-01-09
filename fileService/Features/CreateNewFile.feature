Feature: create new file

    I should create new file if not exist in directory path

    Scenario: create new file
        Given directory path
            And filename
        When order raised to create new file
        Then should create new file in the directory
            And return created file path
        
    Scenario: if file exist
        Given directory path
            And filename
        When creating new file
        Then should not create new file
            And return existed file path