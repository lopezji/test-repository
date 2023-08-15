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
            subgraph b1[Manual Processes 1]
                direction TB
                b11(Process Tar Files) --> b12[/Hashes Files/]
            end

            subgraph b2["Crontab"]
                direction TB 
                b21("Run Job") --> b22(Create Signatures)
                b22 --> b23[/Signature Files/]
            end 

            subgraph b3[Manual Processes 2]
                direction TB
                b31("Create Final Files") --> b32[/Final KB tar files/]
            end

            b12 --> b2
            
            b2 --> b3
     end               

     a --> b

```
