import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario;

  constructor(private router: Router) {
    this.usuario = new Usuario();
  }
  public entrar() {
    if (this.usuario.email == "aaa@aaa.com" && this.usuario.senha == "aaa")
    {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/']);
    }
    }
}
