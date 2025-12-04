# curso_cleanarch

Resumo
- Projeto de exemplo para aplicar princípios de Clean Architecture: separação entre entidades, casos de uso, interfaces e infraestrutura.
- Foco: legibilidade, testabilidade e independência de frameworks.

Principais funções
- Implementar casos de uso (use-cases) que orquestram regras de negócio.
- Definir entidades e contratos (interfaces) independentes de infraestrutura.
- Fornecer adaptadores para persistência, transporte (HTTP/CLI) e testes.
- Conjunto de testes automatizados para validar regras de negócio.

Como usar (passos gerais)
1. Pré-requisitos: instale a linguagem e ferramentas do projeto (ex.: Node, Python, PHP, Docker).
2. Clonar e entrar no diretório:
    - git clone <repo-url>
    - cd curso_cleanarch
3. Instalar dependências (substitua conforme a stack):
    - Node: npm install
    - Python: pip install -r requirements.txt
    - PHP: composer install
4. Configurar variáveis de ambiente em .env (se houver).
5. Rodar a aplicação:
    - Node (exemplo): npm start
    - Python (exemplo): python -m src.main
6. Executar testes:
    - npm test / pytest / vendor/bin/phpunit

Estrutura sugerida
- src/
  - entities/         — modelos de domínio
  - usecases/         — regras de negócio
  - controllers/      — entrada (HTTP, CLI)
  - repositories/     — contratos de persistência
  - infra/            — implementações concretas (DB, adapters)
- tests/              — testes unitários e de integração
- docs/               — documentação adicional

Como contribuir
- Abrir issue para discutir alterações.
- Criar branch descritiva: feat/xxx ou fix/yyy.
- Submeter PR com testes que cubram a mudança.

Notas
- Mantenha dependências e frameworks isolados dos casos de uso.
- Priorize testes unitários para regras de negócio.

Licença
- Adicionar arquivo LICENSE conforme necessário.

(Substitua comandos e caminhos conforme a stack real do projeto.)