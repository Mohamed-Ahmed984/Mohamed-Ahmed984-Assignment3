# Stack and Heap Diagrams

The diagrams below trace this exact sequence:

```csharp
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;
```

## Diagram 1 — After creating `o1`

```text
STACK                         HEAP
--------------------          ---------------------------------
o1: 0x01  ------------------> Order object at 0x01
                              OrderId: 1
                              CustomerName: "Ali"
                              IsPaid: false
```

`o1` is a reference variable. It holds the address `0x01`, which points to the `Order` object stored on the heap.

## Diagram 2 — After assigning `o2 = o1`

```text
STACK                         HEAP
--------------------          ---------------------------------
o1: 0x01  -----------\
                        ----> Order object at 0x01
o2: 0x01  -----------/       OrderId: 1
                              CustomerName: "Ali"
                              IsPaid: false
```

The reference is copied, not the object. Both `o1` and `o2` point to the same object on the heap.

### Handwritten diagrams 1 and 2

![Handwritten stack and heap diagrams 1 and 2](assets/stack_heap_diagrams_1_2.png)

## Diagram 3 — After changing `o2.IsPaid`

```text
STACK                         HEAP
--------------------          ---------------------------------
o1: 0x01  -----------\
                        ----> Order object at 0x01
o2: 0x01  -----------/       OrderId: 1
                              CustomerName: "Ali"
                              IsPaid: true
```

Changing `o2.IsPaid` updates the shared heap object. Therefore, both `o1.IsPaid` and `o2.IsPaid` are `true`.

### Handwritten diagram 3

![Handwritten stack and heap diagram 3](assets/stack_heap_diagram_3.png)

## What would be different with a `struct`?

A `struct` is a value type. Assigning one struct variable to another copies its values, so changing the second variable would not change the first variable.
