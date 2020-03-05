import { Component } from "@angular/core";
@Component({
    selector: "app-produto",
    template: "<html><body>{{ getName() }}</body></html>"
})
export class ProdutoComponent {
    public nome: string;
    public liberadoParavenda: boolean;
    public obterNome(): string {
        return this.nome;
    }
}
