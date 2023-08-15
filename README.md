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
            subgraph b1[Manual Processes]
                direction TB
                b11(Process Tar Files) --> b12[/Hashes Files/]
                c1("Create Final Files") --> c2[/Final KB tar files/]
            end

            subgraph b2["Crontab"]
                direction TB 
                b21("Run Job") --> b22(Create Signatures)
                b22 --> b23[/Signature Files/]
            end 

            b12 --> b2
            
            b2 --> c1
     end               

     a --> b

```
