# Anchor Sim Traffic Mark Walkthrough

This note is the quickest way to read the extra review model in `anchor-sim-traffic-mark`.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 160 | ship |
| stress | state drift | 175 | ship |
| edge | review cost | 212 | ship |
| recovery | decision risk | 165 | ship |
| stale | input pressure | 177 | ship |

Start with `edge` and `baseline`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`edge` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
