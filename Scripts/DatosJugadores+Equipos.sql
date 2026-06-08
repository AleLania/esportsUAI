USE esportsUAI;
GO

-- DISCIPLINAS

INSERT INTO Disciplinas
(DESCRIPCION, CANTIDAD_JUGADORES_EQUIPO)
VALUES
('FIFA', 2),
('DOTA2', 5);

-- EQUIPOS FIFA (ID_DISCIPLINA = 1)

INSERT INTO Equipos
(NOMBRE, ID_DISCIPLINA, PG_TORNEO, PP_TORNEO, PE_TORNEO, PUNTOS)
VALUES
('Boca Esports', 1, 0, 0, 0, 0),
('River Gaming', 1, 0, 0, 0, 0),
('Racing FC', 1, 0, 0, 0, 0),
('Independiente Pro', 1, 0, 0, 0, 0),
('San Lorenzo eSports', 1, 0, 0, 0, 0),
('Huracan Gaming', 1, 0, 0, 0, 0),
('Velez Virtual', 1, 0, 0, 0, 0),
('Estudiantes Pro', 1, 0, 0, 0, 0);

-- EQUIPOS DOTA2 (ID_DISCIPLINA = 2)

INSERT INTO Equipos
(NOMBRE, ID_DISCIPLINA, PG_TORNEO, PP_TORNEO, PE_TORNEO, PUNTOS)
VALUES
('Radiant Wolves', 2, 0, 0, 0, 0),
('Dire Titans', 2, 0, 0, 0, 0),
('Ancient Guardians', 2, 0, 0, 0, 0),
('Roshan Hunters', 2, 0, 0, 0, 0),
('Phantom Squad', 2, 0, 0, 0, 0),
('Divine Force', 2, 0, 0, 0, 0),
('Ancient Legends', 2, 0, 0, 0, 0),
('Team Barracks', 2, 0, 0, 0, 0);

-- JUGADORES FIFA (Equipos 1 al 8)

INSERT INTO Jugadores (NOMBRE_APELLIDO, NICK, ID_EQUIPO) VALUES
('Juan Perez', 'JP10', 1),
('Martin Lopez', 'MLOPEZ', 1),

('Lucas Gomez', 'RIVERKING', 2),
('Franco Diaz', 'FRANCOFC', 2),

('Nicolas Ruiz', 'NICORUIZ', 3),
('Santiago Torres', 'STORRES', 3),

('Matias Silva', 'MATYGAMER', 4),
('Bruno Vega', 'BRUNOVEGA', 4),

('Agustin Castro', 'AGUSFC', 5),
('Tomas Rojas', 'TOMIGOL', 5),

('Joaquin Perez', 'JOACO11', 6),
('Kevin Torres', 'KEVINPRO', 6),

('Alan Medina', 'ALANFC', 7),
('Facundo Lopez', 'FACUGAMER', 7),

('Gonzalo Ruiz', 'GONZAPRO', 8),
('Leo Sanchez', 'LEOFIFA', 8);

-- JUGADORES DOTA2 (Equipos 9 al 16)

INSERT INTO Jugadores (NOMBRE_APELLIDO, NICK, ID_EQUIPO) VALUES
('Carlos Medina', 'CarryGod', 9),
('Diego Suarez', 'MidKing', 9),
('Pablo Ortiz', 'HardSupport', 9),
('Martin Vega', 'OfflanePro', 9),
('Tomas Diaz', 'SoftSupport', 9),

('Ivan Gomez', 'ShadowCarry', 10),
('Emiliano Ruiz', 'InvokerMain', 10),
('Lucas Castro', 'AxeMaster', 10),
('Pedro Silva', 'LionKing', 10),
('Bruno Perez', 'CrystalNova', 10),

('Matias Lopez', 'Jugger', 11),
('Juan Torres', 'StormSpirit', 11),
('Kevin Garcia', 'Centaur', 11),
('Franco Medina', 'CMaster', 11),
('Alan Ruiz', 'WDDoctor', 11),

('Nicolas Diaz', 'PhantomAce', 12),
('Santiago Perez', 'QoPQueen', 12),
('Gonzalo Torres', 'MarsGod', 12),
('Leo Castro', 'RubickMain', 12),
('Facundo Silva', 'Disruptor', 12),

('Cristian Gomez', 'AntiMage', 13),
('Martin Ruiz', 'PudgeHook', 13),
('Lucas Perez', 'TinyToss', 13),
('Juan Lopez', 'OracleSave', 13),
('Bruno Medina', 'DarkWillow', 13),

('Tobias Garcia', 'PAPlayer', 14),
('Ezequiel Torres', 'VoidSpirit', 14),
('Agustin Diaz', 'TimberMain', 14),
('Nicolas Castro', 'ShadowShaman', 14),
('Kevin Lopez', 'JakiroFire', 14),

('Matias Gomez', 'SlarkKing', 15),
('Franco Ruiz', 'EmberSpirit', 15),
('Alan Perez', 'BeastMaster', 15),
('Leo Medina', 'WarlockMain', 15),
('Pedro Torres', 'DazzleHeal', 15),

('Tomas Castro', 'SpectreCarry', 16),
('Joaquin Ruiz', 'PuckPlayer', 16),
('Gonzalo Perez', 'BristleBack', 16),
('Cristian Torres', 'WitchDoctor', 16),
('Lucas Medina', 'LichSupport', 16);