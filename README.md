To test graphs in github


```mermaid
flowchart LR
    subgraph BUILD MACHINE
        direction LR
        subgraph .tar Files
        end
        subgraph Hashes
        end
     end

     subgraph Hash signing server
        direction LR
            subgraph Generate Hashes
                direction TB
                 Process tar files --> Hashes files
            end
            subgraph Crontab
                direction TB 
                RunJob --> CreateSignatures
            end 
            Generate Hashes --> Crontab
     end               

     BUILD MACHINE --> Hash signing server

```
