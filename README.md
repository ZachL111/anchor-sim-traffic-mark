# anchor-sim-traffic-mark

`anchor-sim-traffic-mark` is a C# project in simulations. Its focus is to create a C# reference implementation for traffic workflows, centered on stream reduction, windowed input fixtures, and late-data behavior checks.

## Project Rationale

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Anchor Sim Traffic Mark Review Notes

Start with `review cost` and `input pressure`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Feature Set

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/anchor-sim-traffic-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `review cost` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Architecture

The repository has two validation layers: the original compact policy fixture and the domain review fixture. They are separate so one can change without hiding failures in the other.

The C# implementation avoids hidden state so fixture changes are easy to reason about.

## Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Test Command

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Next Improvements

The repository is intentionally scoped to local checks. I would expand it by adding adversarial fixtures before adding features.
