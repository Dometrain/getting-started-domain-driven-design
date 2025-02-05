using DomeGym.Domain.RoomAggregate;
using ErrorOr;
using MediatR;

namespace DomeGym.Application.Rooms.Queries.GetRoom;

public record GetRoomQuery(
    Guid GymId,
    Guid RoomId) : IRequest<ErrorOr<Room>>;