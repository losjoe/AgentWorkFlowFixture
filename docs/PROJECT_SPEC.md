# Project Specification

StatusLamp represents one binary status lamp with local, ephemeral state.

## Current behavior

- State is a `bool` and initially `false`.
- `false` displays the exact text `0` on a red status area.
- `true` displays the exact text `1` on a green status area.
- One Toggle action changes `false` to `true` and `true` to `false`.

## Boundaries

The current product has no persistence, status history, multiple lamps, networking, or external device integration. Colors are not configurable unless a future authorized task changes that decision.
