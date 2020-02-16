package com.exemplo;

public enum TipoJogo {
	ACAO("Ação"), AVENTURA("Aventura"), RPG("Role-playing game");

	private String descricao;

	private TipoJogo(String descricao) {
		this.descricao = descricao;
	}

	public String getDescricao() {
		return descricao;
	}
}
