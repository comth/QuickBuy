import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario;
  public usuarioAutenticado: boolean;

  constructor() {
    this.usuario = new Usuario();
  }
  public entrar() {
    if (this.usuario.email == "aaa" && this.usuario.senha == "aaa")
    {
      this.usuarioAutenticado = true;
    }
    }
}
