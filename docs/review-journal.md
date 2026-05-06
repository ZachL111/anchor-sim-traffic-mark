# Review Journal

The cases below are the review handles I would use before changing the implementation.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 160, lane `ship`
- `stress`: `state drift`, score 175, lane `ship`
- `edge`: `review cost`, score 212, lane `ship`
- `recovery`: `decision risk`, score 165, lane `ship`
- `stale`: `input pressure`, score 177, lane `ship`

## Note

A future change should add new cases before it changes the scoring rule.
