To test graphs in github


```mermaid
%%{init: {"flowchart": {"htmlLabels": false}} }%%
flowchart LR
    subgraph a"BUILD MACHINE"
        direction LR
        subgraph a1/".tar Files"/
        end
        subgraph a2/"Hashes"/
        end
     end

     subgraph b"HashSigningServer"
        direction LR
            subgraph GenerateHashes
                direction TB
                 (Process Tar Files) --> /"Hashes Files"/
            end
            subgraph Crontab
                direction TB 
                RunJob --> CreateSignatures
            end 
            GenerateHashes --> Crontab
     end               

     "BUILD MACHINE" --> HashSigningServer

```
