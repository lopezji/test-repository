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
        direction TB
            subgraph b1[Generate Hashes]
                direction TB
                 b11[Process Tar Files] --> b12[/Hashes Files/]
            end

            subgraph b2["Crontab"]
                direction TB 
                b21["Run Job"] --> b22[Create Signatures]
                b22 --> b23[/Signature Files/]
            end 

            c1("Create Final Files") --> c2[/Final KB tar files/]

            b12 --> b21
            
     end               

     a --> b21

     b -- "Final KB tar files" --> a
```
