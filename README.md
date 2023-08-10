To test graphs in github


```mermaid
%%{init: {"flowchart": {"htmlLabels": false}} }%%
flowchart LR
    subgraph a["BUILD MACHINE"]
        direction TB
            a1[/Tar Files/]
            a2[/Hashes/]
    end

     subgraph b["Hash Signing Server"]
        direction LR
            subgraph b1[Generate Hashes]
                direction TB
                 b11[Process Tar Files] --> b12[/Hashes Files/]
            end

            subgraph Crontab
                direction TB 
                RunJob --> b2[Create Signatures]
                b2 --> b3[/Signature Files/]
            end 

            c1("Create Final Files") --> c2[/Final KB tar files/]


            b12 --> Crontab
            
     end               

     a --> b

     b -- "Final KB tar files" --> a
```
