# practice-csharp

> `C#`을 공부하면서 자료구조 및 알고리즘을 구현하는 과정을 기록하는 공간입니다. 단순 자료구조 및 알고리즘을 구현하며, 아래 `Ref`를 참고해서 진행합니다.

## 준비사항

- `.NET 7`

  - Windows 사용자는 `Visual Studio 2022`를 설치하시면 됩니다.
  - `Linux`, `macOS`는 `dotnet`(>= 7)을 설치해주시면 됩니다.
    - macOS 사용자는 `brew install dotnet`을 활용하세요.
    - Linux 사용자는 `sudo apt install dotnet-sdk-7.0`을 활용하세요.

- IDE
  - Windows 사용자는 `Visual Studio 2022`를 사용하세요(적극 권장).
  - macOS 및 Linux 사용자는 `Visual Studio Code`를 사용하세요.
  - 개인적으론 Windows 환경에서 VS(Visual Studio 2022)를 사용하는 것을 권장합니다.

## 실행

```bash
$ git clone https://github.com/sigmadream/practice-csharp.git
$ cd practice-csharp
$ dotnet test
```

## 구현 목록

- [x] Linked List
  - [x] Singly Linked List
  - [x] Doubly Linked List
  - [x] Skip Linked List
- [x] Stack
  - [x] Array Stack
  - [x] List Stack
- [x] Queue
  - [x] Array Queue
  - [x] List Queue
- [ ] Tree
  - [ ] Binary Search Tree
  - [ ] AVL Tree
  - [ ] Red-Black Tree
  - [ ] Heap
- [ ] Graph
  - [ ] Directed Weighted Graph Via Adjacency Matrix

## Ref.

- [.NET fundamentals documentation](https://learn.microsoft.com/en-us/dotnet/fundamentals?WT.mc_id=DOP-MVP-5001859)
- [JavaScript Algorithms and Data Structures](https://github.com/trekhleb/javascript-algorithms)
- `slide-notes`는 관련 문서가 포함되어 있습니다.
