# General
Establish the scope of the session

## Goals

My question to Dave initially was:  
_"Do you make a habit to extract the calling of the SUT into the DSL in order to write tests where you only provide the calling parameters you deem interesting in the context of the test?"_

As Dave puts it:  
 _"This is getting into the nitty-gritty of the separation of concerns in the architecture of the testing approach that I strongly recommend."_

 That's what I'm after: the nitty-gritty.  
Some main goals to strive towards in this session:

#### Tests should contain no extraneous details
- Keeps them maintainable
- Ideally 2-5 lines long

#### Tests should be readable by non-technical business experts
- Acceptance tests should tell nothing about how the system works.

## Specific Subjects

### DSL
[DSL Questions](./DSL.md)

### Given/Arrange
[Given/Arrange Questions](./GivenArrange.md)

### When/Act
[When/Act Questions](./WhenAct.md)

### Then/Assert
[Then/Assert Questions](./ThenAssert.md)


## Final Notes
- Any book recommendations on this subject?